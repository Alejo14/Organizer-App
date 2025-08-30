import "./App.css";
import Navbar from "./layout/Navbar/Navbar";
import BucketsPage from "./pages/Buckets.Page";

function App() {
  return (
    <>
      <section className="nav-bar">
        <Navbar />
      </section>
      <section className="content">
        <BucketsPage />
      </section>
      <section className="footer"></section>
    </>
  );
}

export default App;
