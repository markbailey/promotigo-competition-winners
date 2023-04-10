import {
  ChangeEvent,
  FormEvent,
  HTMLAttributes,
  SelectHTMLAttributes,
  useContext,
  useRef,
} from 'react';
import classNames from 'classnames';
import styles from '../assets/stylesheets/form.module.scss';
import Button from './Button';
import { DataContext } from '../context/data';
import { mount } from '../utilities/show';

type SelectOption = { value: string; text: string };

export type FormProps = Omit<HTMLAttributes<HTMLFormElement>, 'onSubmit'> & {
  onSubmit: (event: FormEvent<HTMLFormElement>, value: number) => void;
};

export type SelectProps = SelectHTMLAttributes<HTMLSelectElement> & {
  placeholder?: string;
  options: SelectOption[];
};

function Select(props: SelectProps) {
  const { placeholder, options, ...otherProps } = props;
  return (
    <select {...otherProps} className={styles.formControl}>
      <option value="" disabled>
        {placeholder ?? 'Select an option'}
      </option>

      {options.map((option) => (
        <option key={option.value} value={option.value}>
          {option.text}
        </option>
      ))}
    </select>
  );
}

function Form(props: FormProps) {
  const { client, competition, clients, competitions, playerIds, setClient, setCompetition } =
    useContext(DataContext);
  const inputRef = useRef<HTMLInputElement>(null);
  const { className, onSubmit, ...otherProps } = props;
  const newClassName = classNames(styles.form, className);

  const handleSubmit = (event: FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    if (inputRef.current?.value && null !== null) return;
    onSubmit(event, Number(inputRef.current?.value));
  };

  const onClientChange = (event: ChangeEvent<HTMLSelectElement>) => {
    const clientId = event.target.value;
    const client = clients.find((client) => client.id === clientId);
    if (client !== undefined) setClient(client);
  };

  const onCompetitionChange = (event: ChangeEvent<HTMLSelectElement>) => {
    const competitionId = event.target.value;
    const competition = competitions.find((competition) => competition.id === competitionId);
    if (competition !== undefined) setCompetition(competition);
  };

  return (
    <form {...otherProps} className={newClassName} onSubmit={handleSubmit}>
      <Select
        placeholder="Select a client"
        value={client?.id ?? ''}
        onChange={onClientChange}
        options={clients.map((client) => ({ value: client.id, text: client.name }))}
        required
      />

      {mount(
        client !== null,
        <Select
          placeholder="Select a competition"
          value={competition?.id ?? ''}
          onChange={onCompetitionChange}
          options={competitions.map((competition) => ({
            value: competition.id,
            text: competition.title,
          }))}
          required
        />
      )}

      {mount(
        playerIds.length > 0,
        <input
          ref={inputRef}
          type="number"
          placeholder="Enter the number of winners to draw"
          className={styles.formControl}
          min={1}
          max={playerIds.length}
          required
        />
      )}

      {mount(
        client !== null,
        <div className={styles.buttonGroup}>
          {mount(
            playerIds.length > 0,
            <Button type="submit" color="primary">
              Draw Winners
            </Button>
          )}

          <Button type="button" onClick={() => setClient(null)}>
            Cancel
          </Button>
        </div>
      )}
    </form>
  );
}

export default Form;
