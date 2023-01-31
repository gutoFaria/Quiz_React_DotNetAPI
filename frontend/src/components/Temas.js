import React,{useState,useEffect} from 'react'
import axios from 'axios'
import {Link} from 'react-router-dom'
import './Temas.css'

export const Temas = () => {

    const baseUrl = "http://localhost:5226/getalltemas";
    const [data,setData] = useState([]);


  const getTema= async()=>{
    await axios.get(baseUrl)
      .then(response=>{
        setData(response.data);
      }).catch(error => {console.log(error)})  
  }

  useEffect(()=>{
    getTema()
    
  },[])

  return (
    <div className='container'>
        <div class="row">
            {data.map(tema =>(
                <div key={tema.id} className='col-sm-6'>
                    <div className='card'>
                    <div className="card-body">
                    <h5 className="card-title">{tema.title}</h5>
                    <Link to={{pathname:`/quiz/${tema.title}`}}  className='btn btn-primary'>Começar</Link>
                    </div>
                    </div>
                </div>
            ))}
</div>
    </div>
  )
}
