import { PointerEvent, KeyboardEvent, useState, ButtonHTMLAttributes } from 'react';
import classNames from 'classnames';
import styles from '../assets/stylesheets/button.module.scss';

export type ButtonProps = ButtonHTMLAttributes<HTMLButtonElement> & {
  color?: 'primary' | 'danger';
};

function Button(props: ButtonProps) {
  const [pressed, setPressed] = useState(false);
  const { className, color, ...otherProps } = props;
  const newClassName = classNames(styles.button, color && styles[color], className);

  const onInteract = (event: PointerEvent | KeyboardEvent) => {
    const isPointerDown = event.type === 'pointerdown';
    const isLeftClick = (event as PointerEvent).button === 0;
    const isKeyDown = event.type === 'keydown';
    const isEnter = (event as KeyboardEvent).key === 'Enter';
    const newIsPressed = (isPointerDown && isLeftClick) || (isKeyDown && isEnter);

    setPressed(newIsPressed);
  };

  return (
    <button
      type="button"
      {...otherProps}
      className={newClassName}
      onPointerDown={onInteract}
      onKeyDown={onInteract}
      aria-pressed={pressed}
    />
  );
}

export default Button;
