const nextBtns = document.querySelectorAll('.next')
const goBackBtns = document.querySelectorAll('.go-back')
const pages = document.querySelectorAll('.pages')

let idx

nextBtns.forEach((next, index) => {
    next.addEventListener('click', () => {
        shuffleCard(index)
        console.log(index)
        // next.style.transform = 'translate()'
    })
});

goBackBtns.forEach((pre, index) => {
    pre.addEventListener('click', () => {
        if (index > 0) {
            index--
            shuffleCard(index)
        } 
        if (index <= 0) {
            shuffleCard(3)    
        }
        console.log(index)
        // next.style.transform = 'translate()'
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