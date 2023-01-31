import React from 'react'
import { BrowserRouter, Route , Routes} from 'react-router-dom';
import { Login } from './components/Login';
import { Quiz } from './components/Quiz';
import { Temas } from './components/Temas';


export const Rotas = () => {
  return (
    <BrowserRouter>
            <Routes>
                <Route path="/" exact element={<Temas/>}/>
                <Route path="/login"  element={<Login/>}/>
                <Route path="/quiz/:name"  element={<Quiz/>}/>
            </Routes>
        </BrowserRouter>
  )
}
