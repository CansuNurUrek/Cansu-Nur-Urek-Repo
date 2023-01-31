import './App.css';
import Navbar, { Alt_Navbar } from './components/navbar';
import Part from './components/body';
import { useState } from 'react';
import PicContainer from './components/container'
import Activities from './components/Activities';



function App() {
 
  return (
    <div className="App">
   
      <Navbar/>
      <Alt_Navbar/>
      <Part/>
      <PicContainer/>
      <Activities/>

    </div>
  );
}

export default App;
