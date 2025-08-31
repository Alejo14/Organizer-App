import type { BucketProps } from "./types/buckets.types";
import "./styles/buckets.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faWrench, faCheck } from "@fortawesome/free-solid-svg-icons";

const Bucket: React.FC<BucketProps> = ({ bucket }) => {
  return (
    <div key={bucket.id} className="bucket">
      <h2 className="title">{bucket.title}</h2>
      <p className="description">{bucket.description}</p>
      <ul className="items">
        <li className="open-items">
          <FontAwesomeIcon icon={faWrench}></FontAwesomeIcon>
          {bucket.items.opened}
        </li>
        <li className="close-items">
          <FontAwesomeIcon icon={faCheck}></FontAwesomeIcon>
          {bucket.items.closed}
        </li>
      </ul>
    </div>
  );
};

export default Bucket;
