/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var browserify = require('browserify');
var reactify = require('reactify');
var source = require('vinyl-source-stream'); //use conventional text streams with Gulp
var concat = require('gulp-concat'); //concats files

var config = {
    paths: {
        html: './src/*.html',
        js: './src/**/*.js',
        css: [
            'node_modules/bootstrap/dist/css/bootstrap.min.css',
            'node_modules/bootstrap/dist/css/bootstrap-theme.min.css'
        ],
        wwwroot: './wwwroot',
        mainJS: './src/main.js'
    }
}

gulp.task('html', function () {
    gulp.src(config.paths.html)
    .pipe(gulp.dest(config.paths.wwwroot))
});

gulp.task('js', function () {
    browserify(config.paths.mainJS)
    .transform(reactify)
    .bundle()
    .on('error', console.error.bind(console))
    .pipe(source('bundle.js'))
    .pipe(gulp.dest(config.paths.wwwroot + '/scripts'));
});

gulp.task('css', function () {
    gulp.src(config.paths.css)
    .pipe(concat('bundle.css'))
    .pipe(gulp.dest(config.paths.wwwroot + '/css'));
});

gulp.task('default', ['html', 'css']);