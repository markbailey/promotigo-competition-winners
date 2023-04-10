import { FormEvent, Fragment, useContext, useEffect } from 'react';

import { DataContext } from './context/data';
import { ReactComponent as InfoGraphic } from './assets/info-graphic.svg';
import Header from './components/Header';
import Loader from './components/Loader';
import styles from './assets/stylesheets/app.module.scss';
import { mount } from './utilities/show';
import Form from './components/Form';
import Button from './components/Button';
import PlayerCard from './components/PlayerCard';
import useMediaQuery from './hooks/useMediaQuery';

function App() {
  const {
    isLoading,
    competition,
    playerIds,
    winners,
    setClient,
    drawCompetitionWinners,
    clearCompetitionWinners,
    getClients,
  } = useContext(DataContext);
  const isMobile = useMediaQuery('(max-width: 47.9375rem)');

  const drawRandomPlayerIds = (_event: FormEvent, count: number) => {
    const terminateNow =
      competition === null || playerIds.length === 0 || count === 0 || count > playerIds.length;
    if (terminateNow) return;

    const newWinnerIds: string[] = [];
    let i = 1;

    while (i <= count) {
      const randomIndex = Math.floor(Math.random() * playerIds.length);
      if (!newWinnerIds.includes(playerIds[randomIndex])) {
        newWinnerIds.push(playerIds[randomIndex]);
        i++;
      }
    }

    drawCompetitionWinners(competition.id, newWinnerIds);
  };

  const onClearWinnersClick = () => {
    if (competition === null) return;
    // Implemented a confirmation dialog to save time on this project.
    // Normally would create a custom dialog component to display confirmation messages.
    const message =
      'Think about the current winners, they will be sorely disappointed.\nAre you sure you want to clear the winners?\nWARNING: This cannot be undone.';
    if (window.confirm(message)) clearCompetitionWinners(competition.id);
  };

  useEffect(() => {
    getClients();
  }, []);

  if (isLoading) return <Loader />;

  return (
    <Fragment>
      <div className={styles.app}>
        <Header />
        <div className={styles.hero}>
          {mount(
            competition?.winnersDrawn !== true,
            <h1>Fill out the form to draw the winners</h1>
          )}

          {mount(competition?.winnersDrawn === true, <h1>{competition?.title} winners</h1>)}
          {mount(
            !isMobile || (isMobile && winners.length === 0),
            <InfoGraphic width={196} height={196} />
          )}
        </div>

        {mount(
          competition?.winnersDrawn === true,
          <main className={styles.grid}>
            {winners.map((winner) => (
              <PlayerCard
                key={winner.id}
                forename={winner.forename}
                surname={winner.surname}
                town={winner.town}
                county={winner.county}
                country={winner.country}
              />
            ))}
          </main>
        )}

        {mount(competition?.winnersDrawn !== true, <Form onSubmit={drawRandomPlayerIds} />)}

        {mount(
          competition?.winnersDrawn === true,
          <footer className={styles.footer}>
            <Button color="danger" onClick={onClearWinnersClick}>
              Clear Winners
            </Button>

            <Button type="button" onClick={() => setClient(null)}>
              Cancel
            </Button>
          </footer>
        )}
      </div>
    </Fragment>
  );
}

export default App;
