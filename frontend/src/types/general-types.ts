export type TBucket = {
  id: number;
  title: string;
  description: string;
  items: {
    opened: number;
    closed: number;
  };
  editable: boolean;
};
