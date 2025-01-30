function activateSection(element, color) {
    // Reset all halves
    document.querySelectorAll('.half').forEach(section => {
        section.classList.remove('active');
        section.style.transform = "scale(1)"; // Reset scale of all sections
        section.style.flex = "1"; // Reset flex size
    });

    // Apply the effect to the clicked section
    element.classList.add('active');
    document.getElementById('body').style.backgroundColor = color;

    // Increase size of the clicked section
    element.style.transform = "scale(1.1)";
    element.style.flex = "1.2"; // Make the clicked section take more space
    setTimeout(() => {
        element.style.transform = "scale(1)";
    }, 500);
}
