import React from 'react'
import ToDo from './Todo'

function ToDoList({todosX, toggleTodo }) {
  return (
    
   todosX.map(todo => {
    return <ToDo key={todo.id} todo={todo} toggleTodo={toggleTodo} ></ToDo>
   })
   
  )
}

export default ToDoList
