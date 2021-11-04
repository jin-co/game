const moves = document.querySelectorAll('.move')
const pages = document.querySelectorAll('.pages')

let idx

moves.forEach((move, index) => {
    move.addEventListener('click', () => {
        console.log('c')
        // two
        pages[0].style.transform = 'translate(0%, 100%)'
        pages[1].style.transform = 'translate(0%, -100%)'
        pages[2].style.transform = 'translate(100%, -100%)'
        pages[3].style.transform = 'translate(100%, 0%)'
        // move.style.transform = 'translate()'
    })
});

function test() {
    // three
    pages[0].style.transform = 'translate(100%, 100%)'
    pages[1].style.transform = 'translate(0%, 0%)'
    pages[2].style.transform = 'translate(100%, -100%)'
    pages[3].style.transform = 'translate(100%, 0%)'
    
    // four
    pages[0].style.transform = 'translate(0%, 100%)'
    pages[1].style.transform = 'translate(0%, -100%)'
    pages[2].style.transform = 'translate(0%, 0%)'
    pages[3].style.transform = 'translate(100%, 0%)'
    
    // one
    pages[0].style.transform = 'translate(0%, 0%)'
    pages[1].style.transform = 'translate(100%, -100%)'
    pages[2].style.transform = 'translate(100%, 0%)'
    pages[3].style.transform = 'translate(0%, 0%)'
}