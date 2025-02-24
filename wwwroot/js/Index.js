function addItem(input_name) {
	const input = document.getElementById(input_name);
	$.ajax({
		url: '?handler=WriteLog&msg=' + input.value,
		success: function (data) {
			alert(data);
		},
		error: function (error) {
			alert("Error: " + error);
		}
	})
	if (input.value) {
		console.log('Item added:', input.value);
		input.value = ''; // Clear the input after adding
	}
	//alert(3);
}