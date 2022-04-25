const uri = 'api/clock';
function getTime() {
    fetch(uri)
        .then(response => { return response.json() })
        .then(time => {
            document.getElementById("displayTime").innerHTML = time.Time;
        })
        .catch(error => console.log('Could not fetch time-api', error));
}