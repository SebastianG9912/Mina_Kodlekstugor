function getTimeV1() {
    fetch('/api/clock')
        .then(response => { return response.json() })
        .then(time => {
            document.getElementById("displayTimeV1").innerHTML = time.time;
        })
        .catch(error => console.log('Could not fetch time-api', error));
}

function getTimeV2() {
    fetch('/api/v1.2/clock')
        .then(response => response.json())
        .then(json => {
            document.getElementById("displayTimeV2").innerHTML = `${json.day}/${json.month} ${json.hour}:${json.minute}:${json.second}`;
        });
}
