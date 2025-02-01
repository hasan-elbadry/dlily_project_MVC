// Get the button and the dropdown menu
const profileBtn = document.getElementById("profileBtn");
const profileDropdown = document.getElementById("profileDropdown");

// Toggle the dropdown when the button is clicked
profileBtn.addEventListener("click", function (event) {
    profileDropdown.classList.toggle("show");
    event.stopPropagation();  // Prevent click event from propagating to the document
});

// Close the dropdown when clicking anywhere outside of the button and dropdown
document.addEventListener("click", function (event) {
    // Check if the clicked target is neither the dropdown nor the button
    if (!profileBtn.contains(event.target) && !profileDropdown.contains(event.target)) {
        profileDropdown.classList.remove("show");
    }
});
