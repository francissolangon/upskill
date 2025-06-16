/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.htmltree1;

import javax.swing.JFrame;
import javax.swing.JTree;
import javax.swing.tree.DefaultMutableTreeNode;
 
public class HtmlTree1 extends JFrame {
 
    private JTree tree;
 
    public HtmlTree1() {
 
        DefaultMutableTreeNode root = new DefaultMutableTreeNode("html");
        DefaultMutableTreeNode head = new DefaultMutableTreeNode("head");
        DefaultMutableTreeNode meta = new DefaultMutableTreeNode("meta");
        DefaultMutableTreeNode title = new DefaultMutableTreeNode("title");
        DefaultMutableTreeNode body = new DefaultMutableTreeNode("body");
        DefaultMutableTreeNode ul = new DefaultMutableTreeNode("ul");
        DefaultMutableTreeNode li1 = new DefaultMutableTreeNode("li");
        DefaultMutableTreeNode li2 = new DefaultMutableTreeNode("li");
        DefaultMutableTreeNode h1 = new DefaultMutableTreeNode("h1");
        DefaultMutableTreeNode h2 = new DefaultMutableTreeNode("h2");
        DefaultMutableTreeNode a = new DefaultMutableTreeNode("a");
 
        head.add(meta);
        head.add(title);
        ul.add(li1);
        ul.add(li2);
        body.add(ul);
        body.add(h1);
        body.add(h2);
        h2.add(a);
        root.add(head);
        root.add(body);
 
        tree = new JTree(root);
        add(tree);
        setTitle("JTree Example");
        setSize(300, 300);
        setVisible(true);
 
        System.out.println("Root node: " + root.getRoot());
        System.out.println("Parent nodes: " + getParent());
        System.out.println("Siblings: " + root.children());
        System.out.println("One-level subtrees: " + getSubtrees(root, 1));
        System.out.println("Nodes per level: " + getNodesPerLevel(root));
        System.out.println("Depth: " + root.getDepth());
        System.out.println("Degree of each one-level subtree: " + getDegreeOfSubtrees(root, 1));
        System.out.println("List of nodes based on breadth-first");
    }
 
    public static void main(String[] args) {
        new HtmlTree();
    }
}