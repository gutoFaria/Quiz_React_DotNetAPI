import React, { useState, useEffect } from 'react'
import {useParams} from 'react-router-dom'
import axios from 'axios'
import './Quiz.css'

export const Quiz = () => {

    const [num,setNum] = useState(0)
    const [data,setData] = useState([]);
    const {name} = useParams()

    if(name === 'Adição')
        setNum(1)
    else
        setNum(4)

    const baseUrl = `http://localhost:5226/getquestions/${num}`

    const getQuestions= async()=>{
        await axios.get(baseUrl)
          .then(response=>{
            setData(response.data);
          }).catch(error => {console.log(error)})  
      }
    
      useEffect(()=>{
        getQuestions()
      },)

      console.log(data)
  return (
    <div className='App'>
        Quiz
    </div>
  )
}
