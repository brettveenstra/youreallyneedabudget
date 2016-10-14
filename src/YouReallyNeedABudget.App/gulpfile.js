var gulp = require('gulp');
var browserify = require('browserify');
var babelify = require('babelify');
var source = require('vinyl-source-stream'); 

var config = {
    paths: {
        html: './src/*.html',
        js: './src/**/*.js',
        mainJS: './src/main.jsx',
        wwwroot: './wwwroot'
    }
}

gulp.task('html', function () {
    gulp.src(config.paths.html)
    .pipe(gulp.dest(config.paths.wwwroot))
});

gulp.task('js', function () {
    browserify(config.paths.mainJS)
    .transform("babelify", {presets: ["react"]})
    .bundle()
    .on('error', console.error.bind(console))
    .pipe(source('bundle.js'))
    .pipe(gulp.dest(config.paths.wwwroot + '/scripts'));
});

gulp.task('default', ['html', 'js']);