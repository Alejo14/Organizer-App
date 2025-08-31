export type GridProps<T> = {
  items: T[];
  renderItem: (item: T, index: number) => React.ReactNode;
}
