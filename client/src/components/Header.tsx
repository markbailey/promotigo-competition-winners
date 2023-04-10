import { HTMLAttributes } from 'react';
import classNames from 'classnames';

import { ReactComponent as Logo } from '../assets/promotigo.svg';
import styles from '../assets/stylesheets/header.module.scss';

function Header(props: HTMLAttributes<HTMLElement>) {
  const { className, ...otherProps } = props;
  const newClassName = classNames(styles.header, className);

  return (
    <header {...otherProps} className={newClassName}>
      <Logo width={250} height={39.08} />
    </header>
  );
}

export default Header;
