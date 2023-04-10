// Data types for the application
declare type DataPayload =
  | Partial<DataState>
  | Client
  | Competition
  | Boolean
  | string
  | Client[]
  | Competition[]
  | Player[]
  | string[]
  | null;

// Action types for the application
declare interface DataAction {
  type: string;
  payload: DataPayload;
}

// State types for the application
declare interface DataState {
  client: Client | null;
  competition: Competition | null;
  clients: Client[];
  competitions: Competition[];
  playerIds: string[];
  winners: Player[];
  isLoading: boolean;
  error: string | null;

  // Methods
  getClients(): void;
  getClientCompetitions(clientId: string): void;
  getCompetitionPlayerIds(competitionId: string): void;
  getCompetitionWinners(competitionId: string): void;
  drawCompetitionWinners(competitionId: string, playerIds: string[]): void;
  clearCompetitionWinners(competitionId: string): void;

  setClient(client: Client | null): void;
  setCompetition(competition: Competition | null): void;
  clearError(): void;
}

// Data types for the application
declare interface Client {
  id: string;
  name: string;
  dateCreated: string;
  dateUpdated: string;
}

declare interface Competition {
  id: string;
  client: string;
  title: string;
  winnersDrawn: boolean;
  openingDate: string;
  closingDate: string;
  dateCreated: string;
  dateUpdated: string;
}

declare interface Player {
  id: string;
  forename: string;
  surname: string;
  email: string;
  telephone: string;
  town: string;
  county: string;
  country: string;
  dateCreated: string;
  dateUpdated: string;
}
