import { PropsWithChildren, createContext, useEffect, useReducer } from 'react';
import useApi from '../hooks/useApi';

enum Action {
  SetState = 'SET_STATE',
  SetClient = 'SET_CLIENT',
  SetCompetition = 'SET_COMPETITION',
  SetClients = 'SET_CLIENTS',
  SetCompetitions = 'SET_COMPETITIONS',
  SetPlayerIds = 'SET_PLAYER_IDS',
  SetWinners = 'SET_WINNERS',
  SetIsLoading = 'SET_IS_LOADING',
  SetError = 'SET_ERROR',
}

const initialState: DataState = {
  client: null,
  competition: null,
  clients: [],
  competitions: [],
  playerIds: [],
  winners: [],
  isLoading: true,
  error: null,

  getClients() {},
  getClientCompetitions() {},
  getCompetitionPlayerIds() {},
  getCompetitionWinners() {},
  drawCompetitionWinners() {},
  clearCompetitionWinners() {},
  setClient() {},
  setCompetition() {},
  clearError() {},
};

export const DataContext = createContext<DataState>(initialState);

function reducer(state: DataState, action: DataAction): DataState {
  switch (action.type) {
    case Action.SetClient:
      return { ...state, client: action.payload as Client };
    case Action.SetCompetition:
      return { ...state, competition: action.payload as Competition | null };
    case Action.SetClients:
      return { ...state, clients: action.payload as Client[] };
    case Action.SetCompetitions:
      return { ...state, competitions: action.payload as Competition[] };
    case Action.SetPlayerIds:
      return { ...state, playerIds: action.payload as string[] };
    case Action.SetWinners:
      return { ...state, winners: action.payload as Player[] };
    case Action.SetIsLoading:
      return { ...state, isLoading: action.payload as boolean };
    case Action.SetError:
      return { ...state, error: action.payload as string | null };
    case Action.SetState:
      return { ...state, ...(action.payload as Partial<DataState>) };
    default:
      return state;
  }
}

export function Provider(props: PropsWithChildren) {
  const { children } = props;
  const [state, dispatch] = useReducer(reducer, initialState);
  const api = useApi((error) => dispatch({ type: Action.SetError, payload: error.message }));

  const clearError = () => dispatch({ type: Action.SetError, payload: null });
  const getCompetitionPlayerIds = async (competitionId: string) => {
    clearError();
    dispatch({ type: Action.SetIsLoading, payload: true });
    const playerIds = await api.getPlayerIdsByCompetitionId(competitionId);
    const payload = { playerIds, isLoading: false };
    dispatch({ type: Action.SetState, payload });
  };

  const getCompetitionWinners = async (competitionId: string) => {
    clearError();
    dispatch({ type: Action.SetIsLoading, payload: true });
    const winners = await api.getCompetitionWinners(competitionId);
    const payload = { winners, isLoading: false };
    dispatch({ type: Action.SetState, payload });
  };

  const setCompetition = (competition: Competition | null) => {
    const payload = { competition, winners: [] };
    dispatch({ type: Action.SetState, payload });
    if (competition === null) return dispatch({ type: Action.SetPlayerIds, payload: [] });
    if (competition.winnersDrawn) getCompetitionWinners(competition.id);
    else getCompetitionPlayerIds(competition.id);
  };

  const getClientCompetitions = async (clientId: string) => {
    clearError();
    dispatch({ type: Action.SetIsLoading, payload: true });
    const competitions = await api.getCompetitionsByClientId(clientId);
    const payload = { competitions, isLoading: false };
    dispatch({ type: Action.SetState, payload });
  };

  const setClient = (client: Client | null) => {
    const payload = { client, competition: null, winners: [] };
    dispatch({ type: Action.SetState, payload });
    if (client !== null) return getClientCompetitions(client.id);
    dispatch({ type: Action.SetCompetitions, payload: [] });
    setCompetition(null);
  };

  const getClients = async () => {
    clearError();
    dispatch({ type: Action.SetIsLoading, payload: true });
    const clients = await api.getClients();
    const payload = { clients, isLoading: false };
    dispatch({ type: Action.SetState, payload });
  };

  const drawCompetitionWinners = async (competitionId: string, playerIds: string[]) => {
    clearError();
    dispatch({ type: Action.SetIsLoading, payload: true });

    const winners = await api.drawCompetitionsWinners(competitionId, playerIds);
    const payload = { winners, isLoading: false };
    const competition = state.competition;

    if (competition !== null)
      dispatch({
        type: Action.SetCompetition,
        payload: { ...competition, winnersDrawn: winners.length > 0 },
      });

    dispatch({ type: Action.SetState, payload });
  };

  const clearCompetitionWinners = async (competitionId: string) => {
    clearError();
    dispatch({ type: Action.SetIsLoading, payload: true });

    if (await api.clearCompetitionWinners(competitionId)) {
      dispatch({ type: Action.SetWinners, payload: [] });
      const competition = state.competition;
      if (competition !== null) {
        dispatch({ type: Action.SetCompetition, payload: { ...competition, winnersDrawn: false } });
        getCompetitionPlayerIds(competition.id);
      }
    }

    dispatch({ type: Action.SetIsLoading, payload: false });
  };

  // Put in simple alert for error to save time on this project.
  // Normally would create a custom error component / modal to display error messages.
  useEffect(() => {
    if (state.error !== null) {
      alert(`Error: ${state.error}`);
      clearError();
    }
  }, [state.error]);

  return (
    <DataContext.Provider
      value={{
        ...state,
        setClient,
        setCompetition,
        getClients,
        getClientCompetitions,
        getCompetitionPlayerIds,
        getCompetitionWinners,
        drawCompetitionWinners,
        clearCompetitionWinners,
        clearError,
      }}
    >
      {children}
    </DataContext.Provider>
  );
}
