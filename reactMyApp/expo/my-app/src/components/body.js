import React,{useState} from 'react'

function Part() {
    const [value, setValue]= useState(0);
  return (
    <div className='part'>
    <h1>Chance Number</h1>
    <button onClick={()=>{setValue(Math.floor(Math.random() * 100))}}>Find</button>
    <h2>{value}</h2>
    </div>
  )
}

export default Part