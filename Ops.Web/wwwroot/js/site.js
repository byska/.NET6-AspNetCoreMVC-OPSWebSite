(function () {
	'use strict';



	var sitePlusMinus = function () {

		var value,
			quantity = document.getElementsByClassName('quantity-container');

		function createBindings(quantityContainer) {
			var quantityAmount = quantityContainer.getElementsByClassName('quantity-amount')[0];
			var increase = quantityContainer.getElementsByClassName('increase')[0];
			var decrease = quantityContainer.getElementsByClassName('decrease')[0];
			increase.addEventListener('click', function (e) { increaseValue(e, quantityAmount); });
			decrease.addEventListener('click', function (e) { decreaseValue(e, quantityAmount); });
		}

		function init() {
			for (var i = 0; i < quantity.length; i++) {
				createBindings(quantity[i]);
			}
		};

		function increaseValue(event, quantityAmount) {
			value = parseInt(quantityAmount.value, 10);

			console.log(quantityAmount, quantityAmount.value);

			value = isNaN(value) ? 0 : value;
			value++;
			quantityAmount.value = value;
		}

		function decreaseValue(event, quantityAmount) {
			value = parseInt(quantityAmount.value, 10);

			value = isNaN(value) ? 0 : value;
			if (value > 0) value--;

			quantityAmount.value = value;
		}

		init();

	};
	sitePlusMinus();


})()

$(document).ready(function () {
	$("#toggle-password").on("click", function () {
		var passwordField = $("#password");
		var passwordFieldType = passwordField.attr('type');

		if (passwordFieldType === 'password') {
			passwordField.attr('type', 'text');
		} else {
			passwordField.attr('type', 'password');
		}
	});
});
document.addEventListener('DOMContentLoaded', function () {
	populateCities();
});

function populateCities() {
	const citiesDropdown = document.getElementById('cities');

	citiesData.forEach(city => {
		const option = document.createElement('option');
		option.value = city.id;
		option.textContent = city.name;
		citiesDropdown.appendChild(option);
	});

	// Populate districts for the initially selected city
	populateDistricts();
}

function populateDistricts() {
	const citiesDropdown = document.getElementById('cities');
	const selectedCityId = citiesDropdown.value;

	const selectedCity = citiesData.find(city => city.id === parseInt(selectedCityId));

	const districtsDropdown = document.getElementById('districts');
	districtsDropdown.innerHTML = ''; // Clear existing options

	selectedCity.districts.forEach(district => {
		const option = document.createElement('option');
		option.value = district.id;
		option.textContent = district.name;
		districtsDropdown.appendChild(option);
	});
}
