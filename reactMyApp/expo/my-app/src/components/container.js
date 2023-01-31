import React, { useState } from 'react'

export default function PicContainer() {
    const handleAnchorClick = (event, message) => {
  
      console.log('Anchor element clicked');
      console.log(message);
    };
  
    return (
      <div className='pic_container'>
    <h1>Get the Random Photo</h1>

        <a
          onClick={event =>
            handleAnchorClick(event, 'https://picsum.photos/200/300')
          }
          href="https://picsum.photos/200/300"
          target="_blank"
          rel="noreferrer"
        >
          Get Photo
        </a>
      </div>
    );
  }

// function PicContainer() {
//     function handleClick(e) {
//         e.preventDefault();
//   return (
//     <div className='picContainer'>
// <a href='https://picsum.photos/seed/picsum/200/300' role={button} onClick={handleClick}></a>
// <button onClick={()=>{}}>Get</button>

// <a href="#" onClick={this.handleClick}>
//       Click me
//     </a>


//     </div>


//   )
// }

// export default PicContainer