import Grid from "../layout/Grid/Grid";
import Bucket from "../components/Bucket/Buckets";

const buckets = [
  {
    id: 1,
    title: "New Bucket",
    description: "New Description",
    items: {
      opened: 1,
      closed: 2,
    },
  },
  {
    id: 2,
    title: "New Bucket 2",
    description: "New Description 2",
    items: {
      opened: 2,
      closed: 1,
    },
  },
  {
    id: 3,
    title: "New Bucket 3",
    description: "New Description 3",
    items: {
      opened: 12,
      closed: 11,
    },
  },
];

const BucketsPage = () => {
  return (
    <>
      <Grid
        items={buckets}
        renderItem={(item, index) => <Bucket key={index} bucket={item} />}
      />
    </>
  );
};

export default BucketsPage;
