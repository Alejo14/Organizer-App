import type { TBucket } from "../types/general-types";

const buckets = [
  {
    id: 1,
    title: "New Bucket",
    description: "New Description",
    items: {
      opened: 1,
      closed: 2,
    },
    editable: false,
  },
  {
    id: 2,
    title: "New Bucket 2",
    description: "New Description 2",
    items: {
      opened: 2,
      closed: 1,
    },
    editable: false,
  },
  {
    id: 3,
    title: "New Bucket 3",
    description: "New Description 3",
    items: {
      opened: 12,
      closed: 11,
    },
    editable: false,
  },
];

class Bucket {
  title = "";
  description = "";
  editable = true;
  items = { opened: 0, closed: 0 };
  id = 0;
  constructor() {}
  setId = (lastId: number) => (this.id = lastId + 1);
  setPropertiesAtRand = () => {
    this.title = `New Bucket ${this.id}`;
    this.description = `New Description for Bucket ${this.id}`;
  };
}

export const createBucket = (): TBucket => {
  const newBucket = new Bucket();
  newBucket.setId(buckets.length);
  newBucket.setPropertiesAtRand();
  buckets.push(newBucket);
  return newBucket;
};

export const getBuckets = (): TBucket[] => {
  return buckets;
};

export const saveBuckets = () => {
  buckets.forEach((item) => {
    if (item.editable) item.editable = false;
  });
};
