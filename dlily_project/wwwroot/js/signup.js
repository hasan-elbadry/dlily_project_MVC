// Get the file input element and the button element
const profilePicInput = document.getElementById('profilePic');
const uploadButton = document.querySelector('.upload-box');

// Add event listener for file input change
profilePicInput.addEventListener('change', function () {
    // Check if a file is selected
    if (profilePicInput.files && profilePicInput.files[0]) {
        // Change button text
        uploadButton.innerHTML = '<i class="fas fa-check me-2"></i> Image Uploaded';

        // Change button color (for example, green color)
        uploadButton.style.backgroundColor = "#28a745"; // Green color

        // Optionally, change the button text color to white
        uploadButton.style.color = "#fff";
    } else {
        // Reset the button to default state if no image is selected
        uploadButton.innerHTML = '<i class="fas fa-upload"></i> Click to upload Profile Picture';
        uploadButton.style.backgroundColor = "#007bff"; // Default blue color
        uploadButton.style.color = "#fff"; // Default white text
    }
});
