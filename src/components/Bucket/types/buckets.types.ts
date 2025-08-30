type Bucket = {
  id: number;
  title: string;
  description: string;
  items: {
    opened: number;
    closed: number;
  };
};

export type BucketProps = {
  bucket: Bucket;
};
