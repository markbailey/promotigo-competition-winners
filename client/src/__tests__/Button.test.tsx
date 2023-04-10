import { render, screen } from '@testing-library/react';
import Button from '../components/Button';

let button: HTMLButtonElement;
const buttonClicked = jest.fn();

describe('Button component', () => {
  beforeAll(() => {
    const textContent = 'My Button';
    render(<Button>{textContent}</Button>);
    button = screen.getByText(textContent);
  });

  it('Verify that Button renders', async () => {
    console.log(button.getAttribute('class'));
    expect(button).toBeInstanceOf(HTMLButtonElement);
  });

  it('Verify Button click', async () => {
    button.addEventListener('click', buttonClicked);
    button.click();
    expect(buttonClicked).toBeCalledTimes(1);
  });
});
