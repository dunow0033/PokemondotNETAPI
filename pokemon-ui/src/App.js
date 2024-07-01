import logo from './logo.svg';
import './App.css';
import { useEffect, useState } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import PokemonList from './pokemon/PokemonList';
import PokemonDetails from './pokemon/PokemonDetails';

function App() {

  const [pokemonList, setPokemonList] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    fetch('http://localhost:5108/Pokemon')
      .then(response => {
        if(response.ok) {
          return response.json();
        }
        throw response;
      })
      .then(data => {
        setPokemonList(data);
      })
      .catch(error => {
        console.error("Error fetching data: ", error);
        setError(error);
      })
      .finally(() => {
        setLoading(false);
      })
  }, [])

  return (
    <div className='App'>
      <header className='App-header'>
        {
          error ?
             "Error" :
        <Router>
          <Routes>
              <Route exact path="/"
                  element = { loading ? "Loading..." : <PokemonList pokemonList={pokemonList} /> } />
              <Route path="/pokemon/:id" element={ loading ? "Loading..." : 
                  <PokemonDetails pokemonList={pokemonList} />
              } />
          </Routes>
        </Router>
      }
      </header>
    </div>
  );
}

export default App;
