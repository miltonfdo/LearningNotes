//linked list
// let myLinkedList={
// 	head:{
// 		value:10,
// 		next:{
// 			value:5,
// 			next:{
// 				value:16,
// 				next:null
// 			}
// 		}
// 	}
// }
class Node {
	constructor(value) {
		this.value = value;
		this.next = null;
	}
}
class LinkedList {
	constructor(value) {
		this.head = {
			value: value,
			next: null
		}
		this.tail = this.head
		this.length = 1
	}
	apppend(value) {

		// const newNode={
		// 	value:value,
		// 	next: null

		// }
		const newNode = new Node(value);
		this.tail.next = newNode;
		this.tail = newNode;
		this.length++;
		return this;
	}

	prepend(value) {
		const newNode = {
			value: value,
			next: null
		}
		newNode.next = this.head;
		this.head = newNode;
		this.length++;
		return this;
	}
	insert(index,value){
		if(index>=this.length){
			return this.apppend(value);
		}
		const newNode={
			value: value,
			next:null
		};
		const leader= this.traverseToIndex(index-1)
		const holdingPointer=leader.next;
		leader.next= newNode;
	}
	traverseToIndex(){
		let counter=0;
		let currentNode=this.head;
		while(currentNode!=null){
			currentNode=currentNode.next;
			counter++;
		}
		return currentNode;
	}
	printList() {
		//function to check array values
		const array = []
		let currentNode = this.head;
		while (currentNode != null) {
			array.push(currentNode.value);
			currentNode = currentNode.next
		}
		return array;
	}
}




const myLinkedList = new LinkedList(10)
console.log(myLinkedList)
myLinkedList.apppend(5)
console.log("\nAfter append\n")

console.log(myLinkedList)

myLinkedList.prepend(16);
console.log("\nAfter prepend\n")
console.log(myLinkedList)
console.log("printList")
console.log(myLinkedList.printList())