//given 2 arrays ,merge and sort the arrays
function mergeSortedArray(array1,array2){
	const mergeArray=[];
	let array1Item=array1[0];
	let array2Item=array2[0];
	let i=1;
	let j=1;
	if(array1.length===0)
	{
		return array2;
	}
	if(array2.length===0)
	{
		return array1;
	}
	while(array1Item||array2Item){
		if(!array2Item|array1Item<array2Item){
			mergeArray.push(array1Item)
			array1Item=array1[i]
			i++;

		}
		else
		{
			mergeArray.push(array2Item)
			array2Item=array2[j]
			j++;


		}
	}

	return mergeArray;

}
console.log(mergeSortedArray([0,3,4,31],[4,6,30]))