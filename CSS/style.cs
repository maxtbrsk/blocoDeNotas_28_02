*{
  margin:0;
  padding:0;
}

header{
  border-bottom: 1px solid #1b85dc;
  height: 10vh;
  display:flex;
}

#logo{
  width: 30vw;
  height: 10vh;
}

#logo img{
  height: 8vh;
}
#display{
  width: 50vw;
}

#user{
  width: 20vw;
}

main{
  margin: 2vh 2vw;
  min-height: 80vh;
}

#notes{
  display: flex;
  flex-wrap: wrap;
  justify-content: space-around;
}

.card a{
  text-decoration: none;
}

#modal-view{
  border:1px solid #1b85dc;
  position: absolute;
  display:none;
  width: 90vw;
  padding:10px;
 
}

#close-modal{
  float:right;
}

#modal{
  border:1px solid #1b85dc;
  position: absolute;
  padding:2vh 2vw;
  display:none;
  width: 90vw;
}

#controls-note{
  display:flex;
  gap:10px;
}
