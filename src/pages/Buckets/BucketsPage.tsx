import "./styles/buckets-page.css";
import Grid from "@/layout/Grid/Grid";
import Bucket from "@/components/Bucket/Buckets";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faPlus, faSave } from "@fortawesome/free-solid-svg-icons";
import { useEffect, useState } from "react";
import {
  getBuckets,
  createBucket,
  saveBuckets,
} from "@/services/buckets-service";
import type { TBucket } from "@/types/general-types";

const BucketsPage = () => {
  const [buckets, setBuckets] = useState<TBucket[]>([]);

  useEffect(() => {
    const data = getBuckets();
    setBuckets(data);
  }, []);

  const handleCreation = (
    e: React.MouseEvent<HTMLButtonElement, MouseEvent>
  ) => {
    e.preventDefault();
    e.stopPropagation();
    const newBuckets = [...buckets, createBucket()];
    setBuckets(newBuckets);
  };

  const handleSave = (e: React.MouseEvent<HTMLButtonElement, MouseEvent>) => {
    e.preventDefault();
    e.stopPropagation();
    saveBuckets();
  };

  return (
    <div className="buckets">
      <div className="title-bar">
        <div className="title">
          <h2>Buckets</h2>
        </div>
        <div className="actions">
          <button className="add-action" onClick={(e) => handleCreation(e)}>
            <FontAwesomeIcon icon={faPlus} /> Create Bucket
          </button>
          <button className="save-action" onClick={(e) => handleSave(e)}>
            <FontAwesomeIcon icon={faSave} /> Save Changes
          </button>
        </div>
      </div>
      {buckets ? (
        <Grid
          items={buckets}
          renderItem={(item, index) => <Bucket key={index} bucket={item} />}
        />
      ) : (
        <p>Loading...</p>
      )}
    </div>
  );
};

export default BucketsPage;
