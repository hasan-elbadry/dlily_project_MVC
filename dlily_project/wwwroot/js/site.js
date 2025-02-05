document.addEventListener("DOMContentLoaded", function () {
    const profileImg = document.getElementById("profileImg");
    const dropdown = document.getElementById("profileDropdown");

    if (!profileImg || !dropdown) {
        console.error("Profile image or dropdown not found!");
        return;
    }

    profileImg.addEventListener("click", function (event) {
        event.stopPropagation(); // Prevent closing when clicking on the image
        dropdown.classList.toggle("active");
    });

    // Close dropdown when clicking outside
    document.addEventListener("click", function (event) {
        if (!dropdown.contains(event.target) && event.target !== profileImg) {
            dropdown.classList.remove("active");
        }
    });
});
