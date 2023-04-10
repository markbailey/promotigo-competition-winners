export interface UseApi {
  getClients: () => Promise<Client[]>;
  getCompetitionsByClientId: (clientId: string) => Promise<Competition[]>;
  getCompetitionById: (competitionId: string) => Promise<string[]>;
  getPlayerIdsByCompetitionId: (competitionId: string) => Promise<string[]>;
  getCompetitionWinners: (competitionId: string) => Promise<Player[]>;
  drawCompetitionsWinners: (competitionId: string, playerIds: string[]) => Promise<Player[]>;
  clearCompetitionWinners: (competitionId: string) => Promise<boolean>;
}

const { VITE_API_URL } = process.env;

function useApi(errorHandler: (error: Error) => void): UseApi {
  const getClients = (): Promise<Client[]> =>
    fetch(`${VITE_API_URL}/clients`)
      .then((response) => response.json())
      .catch(errorHandler);

  const getCompetitionsByClientId = (clientId: string): Promise<Competition[]> =>
    fetch(`${VITE_API_URL}/clients/${clientId}/competitions`)
      .then((response) => response.json())
      .catch(errorHandler);

  const getCompetitionById = (competitionId: string): Promise<string[]> =>
    fetch(`${VITE_API_URL}/competitions/${competitionId}/playerids`)
      .then((response) => response.json())
      .catch(errorHandler);

  const getPlayerIdsByCompetitionId = (competitionId: string): Promise<string[]> =>
    fetch(`${VITE_API_URL}/competitions/${competitionId}/playerids`)
      .then((response) => response.json())
      .catch(errorHandler);

  const getCompetitionWinners = (competitionId: string): Promise<Player[]> =>
    fetch(`${VITE_API_URL}/competitions/${competitionId}/winners`)
      .then((response) => response.json())
      .catch(errorHandler);

  const drawCompetitionsWinners = (competitionId: string, playerIds: string[]): Promise<Player[]> =>
    fetch(`${VITE_API_URL}/competitions/${competitionId}/winners`, {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(playerIds),
    })
      .then((response) => response.json())
      .catch(errorHandler);

  const clearCompetitionWinners = (competitionId: string): Promise<boolean> =>
    fetch(`${VITE_API_URL}/competitions/${competitionId}/winners/clear`, { method: 'POST' })
      .then((response: Response) => response.status === 200)
      .catch((error) => {
        errorHandler(error);
        return false;
      });

  return Object.freeze({
    getClients,
    getCompetitionsByClientId,
    getCompetitionById,
    getPlayerIdsByCompetitionId,
    getCompetitionWinners,
    drawCompetitionsWinners,
    clearCompetitionWinners,
  });
}

export default useApi;
