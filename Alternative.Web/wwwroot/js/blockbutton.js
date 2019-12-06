function EnableSubmit() {
            var btn = document.getElementById("button");
            btn.disabled = false;
}

function SelectCourse(id) {
    let selectedCourse = document.getElementById("courseId");
    selectedCourse.value = id;
}