import { HTMLAttributes } from 'react';
import classNames from 'classnames';

import { ReactComponent as FaceIcon } from '../assets/face.svg';
import styles from '../assets/stylesheets/player-card.module.scss';

export interface PlayerCardProps extends HTMLAttributes<HTMLElement> {
  forename: string;
  surname: string;
  town: string;
  county: string;
  country: string;
}

function PlayerCard(props: PlayerCardProps) {
  const { className, forename, surname, town, county, country, ...otherProps } = props;
  const newClassName = classNames(styles.card, className);

  return (
    <article {...otherProps} className={newClassName}>
      <div className={styles.text}>
        <h2>{`${forename} ${surname}`}</h2>
        <span>{`${town}, ${county}, ${country}`}</span>
      </div>

      <div className={styles.iconContainer}>
        <FaceIcon width={64} height={64} />
      </div>
    </article>
  );
}

export default PlayerCard;
