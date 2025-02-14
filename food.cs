*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: 'montserrat';
    color:white;
}
html,body{
    height: 100%;
    width: 100%;
}
#nav{
    height: 100px;
    width: 100%;
    /* background-color:magenta; */
    display: flex;
    align-items: center;
    padding: 0 95px;
    position:fixed;
    gap: 40px;
    justify-content: flex-start;
    z-index: 99;

}

#cursor{
    height: 20px;
    width: 20px;
    background-color:#95C11E;
    border-radius: 50%;
    position: fixed;
    z-index: 99;

}
#cursor-blur{
    height: 500px;
    width: 500px;
    background-color:#bfe55871;
    border-radius: 50%;
    position: fixed;
    filter:blur(40px);
    z-index: 9;

}
#nav img{
    height: 75px;
    width: 150px;
}

#nav h4{
    text-transform: uppercase;
    font-weight: 500;
}
video{
    height: 100%;
    width: 100%;
    object-fit: cover;
    z-index: -1;
    position: fixed;
    
}
#main{
    background-color: rgba(0,0,0,0.37);
    position: relative;

}
#page1{
    width: 100%;
    height: 100vh;
    position: relative;
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
    text-align: center;
    z-index: 10;
}
#page1 h1{
    font-size: 140px;
    font-weight: 900;
    position: relative;

}
#page1 h1::before{
    content:"Don't Waste Food";
    position: absolute;
    color: #000;
    -webkit-text-stroke: 2px red;
    top: -6px;
    left: -6px;
    z-index: -1;
}
#page1 h2{
    font-size: 35px;
    font-weight: 800;
    margin-top: 10px;
    margin-bottom: 20px;

}
#page1 p{
    font-size: 20px;
    font-weight: 500;
    width: 40%;
}
#page1 #arrow{
    height: 200px;
    width: 200px;
    display: flex;
    align-items: center;
    justify-content: center;
    left: -2%;
    bottom: 0%;
    position: absolute;
    /* background-color: red; */
    background-color: transparent;
    border: 2px solid #95C11E;
    border-radius: 50%;
    transition: all ease 0.5s;
}
#page1 #arrow i{
    font-size: 50px;
    font-weight: 100;
}
#page1 #arrow:hover{
    scale: 0.4;
    background-color: #95C11E;
}
#page2{
    min-width: 100%;
    height: 200vh;
    z-index: 10;
}
#scroller{
    /* background-color: red; */
    white-space: nowrap;
    overflow-x: auto;
    overflow-y: hidden;
    position: relative;
    z-index: 10;
}
#scroller::-webkit-scrollbar{
    display: none;
}
#scroller-in{
    display: inline-block;
    white-space: nowrap;
    animation-name: scroll;
    animation-duration: 30s;
    animation-timing-function: linear;
    animation-iteration-count: infinite;
}

#scroller h4{
    display: inline-block;
    font-size: 140px;
    font-weight: 900;
    font-family: gilroy;
    margin-right: 10px;
    transition: all linear 0.5s;
    color: transparent;
    -webkit-text-stroke: 2px #95C11E;
}
#scroller h4:hover{
    color: #95C11E;
}

@keyframes scroll{
    from{
        transform: translateX(0);
    }
    to{
        transform: translateX(-100%);
    }
}

#about-us{
    height: 40vh;
    width: 100%;
    /* background-color: red; */
    display: flex;
    padding: 0 50px;
    position: relative;
    z-index: 10;
    align-items: center;
    justify-content: space-around;
    margin-top: 50px;
}
#about-us img{
    height: 220px;
    width: 220px ;
    border-radius: 20px;
    object-fit: cover;
}
#about-us-in{
    width: 50%;
    text-align: center;
}
#about-us-in h3{
    font-size: 54px;
    font-weight: 800;
    margin-bottom: 30px;
}
#about-us-in p{
    font-size: 20px;
    line-height: 26px;
}

#cards-container{
    /* background-color: red; */
    height: 60vh;
    display: flex;
    align-items: center;
    gap: 70px;
    justify-content: center;
    position: relative;
    z-index: 10;
    
}
.card{
    height: 80%;
    width: 22%;
    background-color: blue;
    border-radius: 20px;
    background-size: cover;
    background-position: center;
    overflow: hidden;
    transition: all ease 0.6s;
}
#card1{
    background-image: url("do.jpg");
}
#card2{
    background-image: url("ad.jpg");
}
#card3{
    background-image: url("co.jpg");
}

#overlay{
    height: 100%;
    width: 100%;
    background-color: #95C11E;
    padding-top: 160px;
    padding: 30px;
    opacity: 0;
    transition: all ease 0.6s;
}
#overlay h4{
    color: #000;
    text-transform: uppercase;
    font-size: 40px;
    white-space: nowrap;
    margin-bottom: 20px;
    font-weight: 800;
}
#overlay p{
    color: #000;
    font-size: 18px;
}
#overlay:hover {
    opacity: 1;
}
.card:hover{
    transform: rotate(40deg);
    transition: all ease 0.6s;
}
#green-div{
    height: 40vh;
    display: flex;
    margin-top: 70px;
    align-items: center;
    justify-content: space-between;
    background: linear-gradient(to left bottom ,#95C11E,#119F3A);
}
#green-div h4{
    width: 45%;
    line-height: 50px;
    color: #000;
    font-weight: 800;
    text-align: center;
    font-size: 27px;
    text-transform: uppercase;
}
#green-div img{
    height: 100%;
    object-fit: cover;
    width: 14%;
}
#page3{
    height: 100vh;
    width: 100%;
    background-color: #000;
    display: flex;
    position: relative;
    align-items: center;
    justify-content: center;
}
#page3>h4{
    font-size: 35px;
    font-weight: 700;
    width: 60%;
    line-height: 45px;
    text-align: center;
}
#page3 img{
    position: absolute;
    height: 60px;
}
#page3 #colan1{
    left: 15%;
    top: 25%;
}
#page3 #colan2{
    bottom: 25%;
    right: 15%;
}
#page4{
    height: 30vh;
    width: 100%;
    /* background-color: red; */
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 70px;
    position: relative;
}
.elem{
    height: 70%;
    width: 26%;
    overflow: hidden;
    border-radius: 20px;
    position: relative;
}
.elem{
    height: 70%;
    width: 20%;
    overflow: hidden;
}
.elem h2{
    height: 100%;
    width: 100%;
    background-color: #95C11E;
    display: flex;
    color: #000;
    font-weight: 800;
    justify-content: center;
    transition: all ease 0.5s;
    text-transform: uppercase;
    align-items: center;
    font-size: 40px;
    position: absolute;
    z-index: 10;
}
.elem img{
    height: 100%;
    width: 100%;
    object-fit: cover;
    scale: 1.1;
}
.elem:hover h2{
    color: #fff;
    background-color: transparent;
}
.elem:hover h2{
   scale: 1;
}
#page4 h1{
     font-size: 95px;
     position: absolute;
     top: -45px;
     font-weight: 900;
     font-family: gilroy;
     color: #000;
     -webkit-text-stroke: 2px #fff;
}
/* #footer{
    height: 40vh;
    width: 100%;
    background: linear-gradient(to left bottom,#119F3A,#ACE022);
} */
#footer {
    height: 40vh;
    width: 100%;
    background: linear-gradient(to left bottom, #119f3a 0%, #a3d421 80%);
    position: relative;
    display: flex;
    align-items: center;
    justify-content: flex-start;
    gap: 6.5vw;
    padding: 0 100px;
  }
  #footer > img {
    position: absolute;
    left: 0;
    height: 100%;
    z-index: 0;
  }
  #f1 img {
    height: 100px;
  }
  #f1,#f2,#f3,#f4 {
    width:fit-content;
    position: relative;
    z-index: 99;
    /* background-color: red; */
  }
  #f2 h3 {
    font-size: 1.6vw;
    white-space: nowrap;
    text-transform: uppercase;
    color: #000;
    font-weight: 900;
    margin-bottom: 8px;
  }
  
  #f3 h3 {
    font-size: 1.6vw;
    white-space: nowrap;
    text-transform: uppercase;
    color: #000;
    font-weight: 800;
    margin-bottom: 8px;
  }
  #f4 h4 {
    font-size: 1vw;
    white-space: nowrap;
    text-transform: uppercase;
    color: #000;
    font-weight: 600;
    line-height: 20px;
    margin-bottom: 8px;
  }
