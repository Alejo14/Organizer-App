import "./styles/footer.css";

const Footer = () => {
  const currentYear = () => {
    return new Date().getFullYear();
  };

  return (
    <footer className="footer">
      <div className="description">
        <span>
          Application Developed by <i>Alejandro Tapia</i>
        </span>
      </div>
      <div className="copyright">
        <span>Copyright © All rights Reserved {currentYear()}</span>
      </div>
    </footer>
  );
};

export default Footer;
