package com.mycompany.htmltree;

import java.util.Collections;
import javax.swing.JFrame;
import javax.swing.JTree;
import javax.swing.tree.DefaultMutableTreeNode;
 
public class HtmlTree extends JFrame {
 
    private JTree tree;
 
    public HtmlTree() {

        DefaultMutableTreeNode html = new DefaultMutableTreeNode("html");
        DefaultMutableTreeNode head = new DefaultMutableTreeNode("head");
        DefaultMutableTreeNode body = new DefaultMutableTreeNode("body");
        DefaultMutableTreeNode meta = new DefaultMutableTreeNode("meta");
        DefaultMutableTreeNode title = new DefaultMutableTreeNode("title");
        DefaultMutableTreeNode ul = new DefaultMutableTreeNode("ul");
        DefaultMutableTreeNode h1 = new DefaultMutableTreeNode("h1");
        DefaultMutableTreeNode h2 = new DefaultMutableTreeNode("h2");
        DefaultMutableTreeNode li1 = new DefaultMutableTreeNode("li");
        DefaultMutableTreeNode li2 = new DefaultMutableTreeNode("li");
        DefaultMutableTreeNode a = new DefaultMutableTreeNode("a");

        html.add(head);
        html.add(body);
        head.add(meta);
        head.add(title);
        body.add(ul);
        body.add(h1);
        body.add(h2);
        ul.add(li1);
        ul.add(li2);
        h2.add(a);

        tree = new JTree(html);

        DefaultMutableTreeNode root = (DefaultMutableTreeNode) tree.getModel().getRoot();
        System.out.println("Root Node: " + root.toString());
        System.out.print("Parent Nodes: ");
        parents(root);
        System.out.print("\nSiblings: ");
        siblings(root);
        System.out.print("\nOne Level Subtrees: ");
        subtrees(root);
        System.out.print("\nNodes per level: ");
        levels(root);
        System.out.print("\nDepth: " + root.getDepth());

        System.out.print("\nDegree for each one level subtree: ");
        degrees(root);

        System.out.println("\nBreadth-first: " + Collections.list(root.breadthFirstEnumeration()));
        System.out.println("Pre-order: " + Collections.list(root.preorderEnumeration()));
        System.out.println("Post-order: " + Collections.list(root.postorderEnumeration()));

        tree = new JTree(root);
        add(tree);
        setTitle("JTree Example");
        setSize(300, 300);
        setVisible(true);
 
    }

    public static void main(String[] args) {
        new HtmlTree();
    }

    public static void parents(DefaultMutableTreeNode node) {
        if (!node.isLeaf()) {
            System.out.print(node.toString() + ", ");
        }
        for (int i = 0; i < node.getChildCount(); i++) {
            parents((DefaultMutableTreeNode) node.getChildAt(i));
            if (node.isLeaf()) {
                return;
            }
        }
    }

    public static void siblings(DefaultMutableTreeNode node) {
        if (node.getChildCount() > 1) {
            System.out.print(Collections.list(node.children()) + ", ");
        }
        for (int i = 0; i < node.getChildCount(); i++) {
            siblings((DefaultMutableTreeNode) node.getChildAt(i));
            if (node.isLeaf()) {
                return;
            }
        }
    }

    public static void subtrees(DefaultMutableTreeNode node) {
        if (!node.isLeaf()) {
            System.out.print(node.toString() + " - " + Collections.list(node.children()) + ", ");
        }
        for (int i = 0; i < node.getChildCount(); i++) {
            subtrees((DefaultMutableTreeNode) node.getChildAt(i));
            if (node.isLeaf()) {
                return;
            }
        }
    }

    public static void levels(DefaultMutableTreeNode node) {
        int level = node.getLevel();
        System.out.print(node.toString() + " - " + level + ", ");
        for (int i = 0; i < node.getChildCount(); i++) {
            levels((DefaultMutableTreeNode) node.getChildAt(i));
            if (node.isLeaf()) {
                return;
            }
        }
    }

    public static void degrees(DefaultMutableTreeNode node) {
        if (!node.isLeaf()) {
            System.out.print(node.toString() + " - " + node.getChildCount() + ", ");
        }
        for (int i = 0; i < node.getChildCount(); i++) {
            degrees((DefaultMutableTreeNode) node.getChildAt(i));
            if (node.isLeaf()) {
                return;
            }
        }
    }
}
