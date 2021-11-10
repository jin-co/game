const nextBtns = document.querySelectorAll('.next')
const goBackBtns = document.querySelectorAll('.go-back')
const pages = document.querySelectorAll('.pages')


// page moving
nextBtns.forEach((next, index) => {
    next.addEventListener('click', () => {
        shuffleCard(index)
        console.log(index)
        // next.style.transform = 'translate()'
    })
});

let idx = 0
goBackBtns.forEach((pre, index) => {
    pre.addEventListener('click', () => {
        idx = index
        console.log('b: ', idx)
        if (idx >= 0) {
            idx--
            console.log(idx)
            shuffleCard(idx)
        } 
        if (idx < 0) {
            console.log('below: ', idx)
            shuffleCard(3)    
        }
        console.log(idx)
        // next.style.transform = 'translate()'
    })
});
// page moving
const playerCount = document.querySelector('.player-count')
playerCount.addEventListener('click', () => {
    playerCount.readOnly = false
})

playerCount.addEventListener('keydown', (e) => {
    if (e.key === 'Enter') {
        playerCount.readOnly = true
        let count = playerCount.value
        

    }
})

// player choice



// player choice

// functions
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