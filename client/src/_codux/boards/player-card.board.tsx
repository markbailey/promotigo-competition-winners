import { createBoard } from '@wixc3/react-board';
import PlayerCard from '../../components/PlayerCard';

export default createBoard({
  name: 'PlayerCard',
  Board: () => (
    <PlayerCard
      forename="John"
      surname="Smith"
      town="Brighton"
      county="East Sussex"
      country="England"
      // isWinner
    />
  ),
  environmentProps: {
    windowWidth: 1024,
    windowHeight: 768,
  },
});
