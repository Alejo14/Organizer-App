import type { GridProps } from "./types/grid.types";
import "./styles/grid.css";

const Grid = <T,>({ items, renderItem }: GridProps<T>) => {
  return (
    <>
      <div className="grid">
        {items.map((item, index) => renderItem(item, index))}
      </div>
    </>
  );
};

export default Grid;
