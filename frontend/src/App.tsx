import "./App.css";
import Navbar from "./layout/Navbar/Navbar";
import BucketsPage from "./pages/Buckets/BucketsPage";
import Footer from "./layout/Footer/Footer";

function App() {
  return (
    <>
      <section className="nav-bar">
        <Navbar />
      </section>
      <section className="content">
        <BucketsPage />
      </section>
      <section className="footer">
        <Footer />
      </section>
    </>
  );
}

export default App;
