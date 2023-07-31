let counter =0
function count() {
    counter++;
    let heading=document.querySelector('h1')
    heading.innerHTML=counter;
    if(counter % 10 === 0){
        alert(`couner is now ${counter}`)
    }
    else{
      //  alert('came here')
    }
}
//a function which doesnt have name is called anonymous function
//DOMContentLoaded happens when the DOM load is complete
document.addEventListener('DOMContentLoaded',function(){
    document.querySelector('button').onclick = count;
})
