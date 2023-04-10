require('dotenv').config();
require('isomorphic-fetch');
import { renderHook, waitFor } from '@testing-library/react';
import useApi, { UseApi } from '../hooks/useApi';

let clientId: string = '';
let competitionId: string = '';
let api: UseApi;

describe('useApi', () => {
  beforeAll(() => {
    const { result } = renderHook(() => useApi((e) => console.log(e)));
    api = result.current;
  });

  it('should fetch list of clients from the API', async () => {
    await waitFor(async () => {
      const clients = await api.getClients();
      clientId = clients[0].id;

      expect(clients).toBeInstanceOf(Array);
      expect(clients.length).toEqual(3);
      expect(clients[0].name).toEqual('Brooks');
      expect(clients[1].name).toEqual('Coca Cola');
      expect(clients[2].name).toEqual('Ben & Jerrys');
    });
  });

  it('should fetch list of competitions from the API', async () => {
    await waitFor(async () => {
      const competitions = await api.getCompetitionsByClientId(clientId);
      competitionId = competitions[0].id;
      expect(competitions).toBeInstanceOf(Array);
      expect(competitions.length).toEqual(1);
      expect(competitions[0].title).toEqual('Product launch instant win');
    });
  });

  it('should fetch list of players ids from the API', async () => {
    await waitFor(async () => {
      const playerIds = await api.getPlayerIdsByCompetitionId(competitionId);

      expect(playerIds).toBeInstanceOf(Array);
      expect(playerIds.length).toEqual(50);
      expect(typeof playerIds[0]).toEqual('string');
    });
  });
});
