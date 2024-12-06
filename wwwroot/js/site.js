setTitle = (title) => { document.title = title; };

function scrollToTop() {
    window.scrollTo({
        top: 0,
        behavior: 'smooth' // This makes the scroll animated
    });
}