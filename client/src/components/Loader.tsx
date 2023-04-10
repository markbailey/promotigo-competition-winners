import { HTMLAttributes } from 'react';
import classNames from 'classnames';

import { ReactComponent as Logo } from '../assets/promotigo-small.svg';
import styles from '../assets/stylesheets/loader.module.scss';

function Loader(props: HTMLAttributes<HTMLElement>) {
  const { className, ...otherProps } = props;
  const newClassName = classNames(styles.loader, className);
  return (
    <div {...otherProps} className={newClassName}>
      <Logo width={64} height={64} />
      <span>Loading, Please wait...</span>
    </div>
  );
}

export default Loader;
