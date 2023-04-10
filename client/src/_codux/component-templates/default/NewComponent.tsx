import { HTMLAttributes } from 'react';
import classNames from 'classnames';
import styles from './new-component.module.scss';

export interface NewComponentProps extends HTMLAttributes<HTMLElement> {}

/**
 * This component was created using Codux's Default new component template.
 * To create custom component templates, see https://help.codux.com/kb/en/article/configuration-for-new-components-and-templates
 */
function NewComponent(props: NewComponentProps) {
  const { className, ...otherProps } = props;
  const newClassName = classNames(styles.root, className);
  return (
    <div {...otherProps} className={newClassName}>
      NewComponent
    </div>
  );
}

export default NewComponent;
