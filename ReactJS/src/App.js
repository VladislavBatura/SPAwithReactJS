import logo from './logo.svg';
import './App.css';
import Highcharts from 'highcharts'
import HighchartsReact from 'highcharts-react-official';
import { Component } from 'react/cjs/react.production.min';

import {User} from './User';
import {BrowserRouter, Routes, Route} from 'react-router-dom';

function App() {
  return (
    /*<BrowserRouter>
    <Routes>
      <Route path='/' component={User} exact></Route>
    </Routes>
    </BrowserRouter>*/
    new User()
  );
}

export default App;