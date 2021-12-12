//find first occcurance of a number
function firstRecurringCharacterUsingLoop(input) {
	console.log(input)
	for (let i = 0; i < input.length; i++) {
		for (let j = i + 1; j < input.length; j++) {
			if (input[i] === input[j]) {
				console.log(input[i])
			}

		}

	}
	console.log("undefined")

}

function firstRecurringCharacterUsingHash(input) {
	let map = {};
	for (let i = 0; i < input.length; i++) {

		if (map[input[i]]) {
			console.log(input[i])
		}
		else {
			map[input[i]] = i

		}
	}

}

console.log("using Hash")
firstRecurringCharacterUsingHash([1, 2, 1,2, 1, 6, 8])
console.log("using lop")//O(n^2)
firstRecurringCharacterUsingLoop([1, 2, 2, 1, 6, 8])