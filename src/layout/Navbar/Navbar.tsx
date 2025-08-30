import "./styles/styles.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faUserCircle, faUserGear } from "@fortawesome/free-solid-svg-icons";

const Navbar: React.FC = () => {
  return (
    <nav className="nav">
      <div className="app-title">
        <h1>Org.Tool</h1>
      </div>
      <div className="configurations">
        <ul>
          <li>
            <FontAwesomeIcon icon={faUserGear} />
          </li>
          <li>
            <FontAwesomeIcon icon={faUserCircle} />
          </li>
        </ul>
      </div>
    </nav>
  );
};

export default Navbar;
