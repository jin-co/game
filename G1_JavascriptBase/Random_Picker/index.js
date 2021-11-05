const moves = document.querySelectorAll('.move')
const pages = document.querySelectorAll('.pages')

let idx

moves.forEach((move, index) => {
    move.addEventListener('click', () => {
        console.log(index)
        shuffleCard(index)
        
        // move.style.transform = 'translate()'
    })
});

function shuffleCard(index) {
    switch (index) {
        case 0:
            // two
            pages[0].style.transform = 'translate(0%, 100%)'
            pages[1].style.transform = 'translate(0%, -100%)'
            pages[2].style.transform = 'translate(100%, -100%)'
            pages[3].style.transform = 'translate(100%, 0%)'
            break;
        case 1:
            // three
            pages[0].style.transform = 'translate(100%, 100%)'
            pages[1].style.transform = 'translate(0%, 0%)'
            pages[2].style.transform = 'translate(0%, -100%)'
            pages[3].style.transform = 'translate(100%, -100%)'
            break;
        case 2:
            // four
            pages[0].style.transform = 'translate(100%, 0%)'
            pages[1].style.transform = 'translate(100%, 0%)'
            pages[2].style.transform = 'translate(0%, 0%)'
            pages[3].style.transform = 'translate(0%, -100%)'
            break;
        case 3:
            // one
            pages[0].style.transform = 'translate(0%, 0%)'
            pages[1].style.transform = 'translate(100%, -100%)'
            pages[2].style.transform = 'translate(100%, 0%)'
            pages[3].style.transform = 'translate(0%, 0%)'
            break;    
        default:
            break;
    }
}