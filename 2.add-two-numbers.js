/*
 * @lc app=leetcode id=2 lang=javascript
 *
 * [2] Add Two Numbers
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var addTwoNumbers = function (l1, l2) {
    let l1Arr = [];
    let l2Arr = [];

    const traverseNext = (node, arr) => {

        if (!node)
            return;

        arr.push(node.val);
        traverseNext(node.next, arr);
    }

    if (l1.val != null)
        traverseNext(l1, l1Arr);


    if (l2.val != null)
        traverseNext(l2, l2Arr);

    
    let sum = parseInt(l1Arr.reverse().join("")) + parseInt(l2Arr.reverse().join(""));
    sum = sum.toString().split("").reverse();    
    
    const addNode = (node, val) => {
        if (!node.next) {
            node.next = new ListNode(val);
            return;
        }

        addNode(node.next, val);
    }
    
    let listHead;

    sum.forEach((val, i) => {                
        if(i === 0) {
            listHead = new ListNode(val)
        } else {            
            addNode(listHead, parseInt(val));
        }                 
    });
            
    return listHead;
};
// @lc code=end

