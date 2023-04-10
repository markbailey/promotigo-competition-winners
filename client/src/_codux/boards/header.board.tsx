import { createBoard } from '@wixc3/react-board';
import Header from '../../components/Header';

export default createBoard({
  name: 'Header',
  Board: () => <Header title="Win a Motorhome & £30,000!" />,
  environmentProps: {
    windowWidth: 1024,
    windowHeight: 768,
    canvasHeight: 58,
    canvasWidth: 1024,
  },
});
