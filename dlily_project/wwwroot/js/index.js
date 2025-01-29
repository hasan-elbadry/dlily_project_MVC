function activateSection(element, color) {

    document.querySelectorAll('.half').forEach(section => {
        section.classList.remove('active');
    });
    element.classList.add('active');
    document.getElementById('body').style.backgroundColor = color;


    element.style.transform = "scale(1.1)";
    setTimeout(() => {
        element.style.transform = "scale(1)";
    }, 300);
}