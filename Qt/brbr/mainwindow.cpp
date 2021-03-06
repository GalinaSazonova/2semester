#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ui->webView->load(QUrl("http://google.com/"));

    connect(ui->pushButton_3, &QPushButton::pressed, this, &MainWindow::on_pushButton_3_clicked);
    connect(ui->pushButton, &QPushButton::pressed, this, &MainWindow::on_pushButton_clicked);
    connect(ui->pushButton_2, &QPushButton::pressed, this, &MainWindow::on_pushButton_2_clicked);
    connect(ui->pushButton_4, &QPushButton::pressed, this, &MainWindow::on_pushButton_4_clicked);
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_pushButton_clicked()
{
    ui->webView->back();
}

void MainWindow::on_pushButton_2_clicked()
{
    ui->webView->forward();
}

void MainWindow::on_pushButton_4_clicked()
{
    ui->webView->stop();
}

void MainWindow::on_pushButton_3_clicked()
{
    ui->webView->reload();
}

void MainWindow::on_lineEdit_returnPressed()
{
    QString urlToGo = ui->lineEdit->text();
    QUrl url(urlToGo);
    ui->webView->load(url);
}

